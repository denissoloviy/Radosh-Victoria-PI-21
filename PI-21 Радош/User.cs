using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_21_Радош
{
    class User
    {
        private readonly Group _group;
        private readonly Mediator _mediator;
        public string Login { get; set; }
        public string Password { get; set; }

        public User(Group group, string login, string pass, Mediator mediator)
        {
            this._group = group;
            this._mediator = mediator;
            this.Login = login;
            this.Password = pass;
        }

        #region Operations with documents
        public void CreateDocument(string name, AccessLevel accessLevel)
        {
            _mediator.AddDocument(name, this._group.AccessLevel, accessLevel);
        }

        public void RemoveDocument(string name)
        {
            _mediator.RemoveDocument(name, _group.AccessLevel);
        }

        public void EditDocument(string name)
        {
            _mediator.EditDocument(_group.AccessLevel, name);
        }

        public void ReadDocument(string name)
        {
            _mediator.EditDocument(_group.AccessLevel, name);
        }
        #endregion

        public void LogIn(string password)
        {
            if (string.Equals(this.Password, password))
            {
                // success
            }
            else
            {
                // failure
            }
        }

    }
}
