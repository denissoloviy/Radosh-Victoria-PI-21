using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_21_Радош
{
    class Group : ISecurity
    {
        private readonly Mediator _mediator;
        private List<User> users; 
        public AccessLevel AccessLevel { get; }
        public string Name { get;  private set; }

        public Group(string name, AccessLevel accessLevel, Mediator mediator)
        {
            this.Name = name;
            users = new List<User>();
            this.AccessLevel = accessLevel;
            this._mediator = mediator;
            SampleUsers();
        }

        public void CreateUsers(params User[] users)
        {
            foreach (var user in users)
                this.users.Add(user);
        }

        private void SampleUsers()
        {
            users.Add(new User(this, "vasil", "123", _mediator));
            users.Add(new User(this, "anna", "4545", _mediator));
            users.Add(new User(this, "petro", "qwert", _mediator));
        }
    }
}
