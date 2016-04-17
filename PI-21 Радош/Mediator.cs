using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_21_Радош
{
    class Mediator
    {
        private readonly DocumentContainer _container;
        private readonly List<Group> _groups; 
        public Mediator(DocumentContainer container, List<Group> groups)
        {
            this._container = container;
            this._groups = groups;
            FillWithSampleGroups();
            _groups = new List<Group>();
        }

        private void FillWithSampleGroups()
        {
            _groups.Add(new Group("Administrators", AccessLevel.FullAccess, this));
            _groups.Add(new Group("Managers", AccessLevel.ChangeAllowed, this));
            _groups.Add(new Group("Users", AccessLevel.ReadOnly, this));
        }

        public void EditDocument(AccessLevel groupAccess, string documentName)
        {
            _container.GetByName(documentName)?.Edit();
        }

        public void ReadDocument(AccessLevel groupAccess, string name)
        {
            _container.GetByName(name)?.Read();
        }

        public void AddDocument(string name, AccessLevel groupAccess, AccessLevel accessLevel)
        {
            _container.AddDocument(name, groupAccess, accessLevel);
        }

        public void RemoveDocument(string name, AccessLevel groupAccess)
        {
            _container.GetByName(name)?.Remove();
        }
    }
}
