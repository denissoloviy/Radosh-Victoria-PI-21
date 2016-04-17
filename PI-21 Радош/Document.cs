using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_21_Радош
{
    enum Operation
    {
        Read, Edit, Remove, Add
    }
    class Document : ISecureDocument
    {
        public string Name { get; private set; }
        public AccessLevel AccessLevel { get; }

        AccessLevel ISecurity.AccessLevel
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Document (AccessLevel accessLevel, string name)
        {
            this.AccessLevel = accessLevel;
            this.Name = name;
        }

        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
                this.Name = newName;
        }

        public void Remove()
        {
            // видалення документа
        }

        public void Edit()
        {
            // операції із зміни вмісту документа
        }

        public void Read()
        {
            // читання вмісту документа
        }

        public bool UserHasAccess(AccessLevel userAccess, Operation operation)
        {
            var accessLevel = (AccessLevel)Math.Min((int)AccessLevel, (int)userAccess);
            if ((int)accessLevel > (int)operation)
                return true;
            else
                return false;
        }
    }
}
