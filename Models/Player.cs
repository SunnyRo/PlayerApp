using System.ComponentModel.DataAnnotations;
namespace PlayerApp.Models
{
    public class Player 
    {
            private string name;
            private string email;
            private string level;
            private string modelType;
            [Key]
            public Guid Id { get; set; }
            public Player(string name, string email, string level)
            {
                    this.name = name;
                    this.email = email;
                    this.level = level;
                    this.modelType = "Player";
            }
            public Player(string name, string email)
            {
                    this.name = name;
                    this.email = email;
                    this.level = "1";
                    this.modelType = "Player";
            }
            public string Name { get => name; set { this.name = value; } }
            public string Email { get => email; set { this.Email = value; } }
            public string Level { get => level; set { this.level = value; } }
            public string ModelType { get => modelType; set { this.modelType = "Player"; } }
    }

}