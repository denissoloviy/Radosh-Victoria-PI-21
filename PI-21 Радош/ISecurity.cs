using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PI_21_Радош
{
    enum AccessLevel
    {
        NoAccess, // жодних прав
        ReadOnly, // можливіть лише читання
        ChangeAllowed, // дозволені лише зміна документа та читання
        FullAccess // дозволені всі операції
    }
    interface ISecurity
    {
        AccessLevel AccessLevel { get; }
    }

    interface ISecureDocument : ISecurity
    {
        bool UserHasAccess(AccessLevel userAccess, Operation operation);
    }
}
