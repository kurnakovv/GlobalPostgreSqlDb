using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalDB
{
    [Table("user")]
    public class UserEntity
    {
        [Column("id_user")]
        public long Id { get; set; }

        [Column("u_name")]
        public string Name { get; set; }
    }
}
