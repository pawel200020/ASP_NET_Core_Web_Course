using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Web;

namespace Entity_Framework_APP.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Car Model")]

    public string Carm { get; set; }
        [Required]
        public double MPG { get; set; }
        [Required]
        public int Cylinders { get; set; }
        [Required]
        public  double Displacement { get; set; }
        [Required]
        public double Horsepower { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public double Acceleration { get; set; }
        [Required]
        public int Model { get; set; }
        [Required]
        public string Origin { get; set; }

        public Car()
        {
            Id = -1;
            Carm = "nothing";
            MPG = 0;
            Cylinders = 0;
            Displacement = 0;
            Horsepower = 0;
            Acceleration = 0;
            Weight = 0;
            Model = 0;
            Origin = "unknown";

        }
        public Car(int id, string carm, double mpg, int cylinders, double displacement, double horsepowe, double weight, int model, string origin)
        {
            Id = id;
            Carm = carm;
            MPG = mpg;
            Cylinders = cylinders;
            Displacement = displacement;
            Horsepower = horsepowe;
            Weight = weight;
            Model = model;
            Origin = origin;

        }
    }
}