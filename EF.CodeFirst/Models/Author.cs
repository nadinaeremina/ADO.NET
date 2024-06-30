using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // подключаем для аннотаций всех сущ-ей
using System.ComponentModel.DataAnnotations; // подключаем для аннотаций полей


namespace EF.CodeFirst.Models
{
    // аннотация всей сущ-ти
    [Table (name:"Authors")] // будет создана такая сущность В БД - таблица
    // если имя хотим такое же, как и у класса, то '(name:"Authors")' - можно не указывать
    public class Author
    {
        // если 'int' один - дефолтно будет ключом, если неск-ко нужно создавать аннотацию
        // аннотация ставится пере полем, где она нужна
        [Key] // аннотация полей // значит это первичный ключ
        public int Id { get; set; }
        [Required] // если наше поле - 'not null' // если не поставим - дефолтно 'null'
        public string FN { get; set; }
        [Required]
        public string LN { get; set; }
        [Required]
        public DateTime? BD { get; set; }
        // это ссылочный пар-р, будем проверять его на null

        //public byte[] Picture { get; set; } // для картинок
    }
}
