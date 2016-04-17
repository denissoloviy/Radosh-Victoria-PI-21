using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_21_Радош
{
    class DocumentContainer : ISecureDocument
    {
        private List<Document> documents;

        public AccessLevel AccessLevel
        {
            get { return AccessLevel.FullAccess;}
        }

        public DocumentContainer()
        {
            this.documents = new List<Document>();
            this.FillWithSamples();
        }

        private void FillWithSamples()
        {
            documents.Add(new Document(AccessLevel.FullAccess, "full_access.txt"));
            documents.Add(new Document(AccessLevel.ChangeAllowed, "for_changing.img"));
            documents.Add(new Document(AccessLevel.ReadOnly, "for_reading.txt"));
            documents.Add(new Document(AccessLevel.NoAccess, "private.txt"));
        }

        public Document GetByName(string name)
        {
            foreach (var doc in documents)
            {
                if (string.Equals(name, doc.Name))
                    return doc;
            }
            return null;
        }

        public void AddDocument(string name, AccessLevel userAccess, AccessLevel docAccess)
        {
            if (UserHasAccess(userAccess, Operation.Add)) 
                this.documents.Add(new Document(docAccess, name));
        }

        public bool UserHasAccess(AccessLevel userAccess, Operation operation)
        {
            return (userAccess >= AccessLevel);
        }
    }
}
