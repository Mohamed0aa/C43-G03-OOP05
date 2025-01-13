using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //abstract class : is partail implementation for other class
    //container of common code [abstract member
    //you cant make aopject from it
    //can make  consractor on abstract class

     abstract class shape
    {
        public decimal Dim1 { get; set; }
        public decimal Dim2 { get; set; }
        public abstract decimal prameter { get; }

        public abstract decimal calcArea();
    }


    //two kind can inherit from abstract class => concrete class or abstract class
    class rect : shape
    {
        public override decimal prameter {
            get
            {
                return (Dim1 + Dim2) * 2;
            }
        }
        public override decimal calcArea()
        {
            return Dim1 * Dim2;
        }

    }

}
