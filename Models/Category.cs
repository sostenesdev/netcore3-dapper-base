using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace meu_blog_netcore.Models {

    // https://github.com/anzolin/AspNetCoreDapperMySql
    // https://medium.com/@rsdsantos/configurando-appsettings-json-em-aplica%C3%A7%C3%B5es-net-core-2-94eb4e035660
    // https://www.treinaweb.com.br/blog/utilizando-o-micro-orm-dapper-em-uma-aplicacao-asp-net-core/    

    [Table ("Category")]
    public class Category {

        public Category(string Description)
        {
            this.Description = Description;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
    }
}