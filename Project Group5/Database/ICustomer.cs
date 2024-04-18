using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Group5.Database
{
    internal interface ICustomer
    {
        string Name { get; set; }
        int PhoneNumber { get; set; }
        string Nationality { get; set; }
        string Gender { get; set; }
        DateTime DateOfBirth { get; set; }
        int IDProof { get; set; }
        string Address { get; set; }
        DateTime CheckInDate { get; set; }
        string BedType { get; set; }
        string RoomType { get; set; }
        int RoomNumber { get; set; }
        double Price { get; set; }
    }
}
