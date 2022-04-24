using System;
using System.Collections.Generic;
using System.Text;

namespace LovDev.Models
{
    public class UserModel
    {
        
        /// <summary>
        /// Nome
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Idade
        /// </summary>
        public string Age { get; set; }
        
        /// <summary>
        /// Descrição curto
        /// </summary>
        public string About { get; set; }
        
        /// <summary>
        /// Localização
        /// Para apresentar a distancia
        /// </summary>
        public string Location { get; set; }
        
        /// <summary>
        /// linguagens e tecnologias
        /// </summary>
        public string[] stacks { get; set; } 
        
        /// <summary>
        /// Foto
        /// </summary>
        public string Photo { get; set; } //provavelmente esse campo da imagem vai deixar de ser string , talvez um stream?
    }
}
