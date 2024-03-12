using SQLite;

namespace ShowBuddy;

[Table("user")]
class User
{
  [PrimaryKey, AutoIncrement, Column("_id")]
  public int Id { get; set; }

  [MaxLength(250), Unique]
  public required string Username { get; set; }

}
