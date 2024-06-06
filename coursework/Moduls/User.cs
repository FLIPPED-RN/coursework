using System.ComponentModel.DataAnnotations;

namespace coursework.Moduls;

public class User
{
    [Key]
    public int user_id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
}