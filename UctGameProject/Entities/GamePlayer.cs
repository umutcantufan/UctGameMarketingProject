using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Abstract;

namespace UctGameProject.Entities
{
    public class GamePlayer :IGamePlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationaltyId { get; set; }

    }
}
