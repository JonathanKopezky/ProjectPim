using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.controller
{
    public class QuartoController
    {
        QuartoRepository quartoRepository = new QuartoRepository();
        Quarto quarto = new Quarto(); 
        
        public DataTable grid()
        {
            return quartoRepository.Grid();
        }
    }
}
