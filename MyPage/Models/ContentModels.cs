using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyPage.Models
{
    public class ContentModels
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        
        public DateTime? Create { get; set; }
        public DateTime? LastModified { get; set; }

        [Required]
        public string Visible { get; set; }
        [Required]
        public int Level { get; set; }
        /*
        `id` INT NOT NULL AUTO_INCREMENT,
  `content` TEXT NULL,
  `create` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `lastmodified` DATETIME NULL ON UPDATE CURRENT_TIMESTAMP,
  `visibe` VARCHAR(45) NOT NULL,
  `level` INT NULL,
        */
    }
}