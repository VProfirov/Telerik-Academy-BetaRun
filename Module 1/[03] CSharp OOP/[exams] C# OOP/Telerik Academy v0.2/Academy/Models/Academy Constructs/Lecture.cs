﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Validation;
using Academy.Models.Outputs;

namespace Academy.Models.Academy_Constructs
{
    class Lecture : ILecture
    {
        private string _name;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Trainer = trainer;
        }

        public string Name
        {
            get => this._name;
            set
            {
                Validator.StringValidation(value, Validator.LectureNameMinLength, Validator.LectureNameMaxLength, Validator.LectureNameErrorMessage);
                this._name = value;
            }
        }
        public DateTime Date { get; set; }
        public ITrainer Trainer { get; set; }
        public IList<ILectureResource> Resources { get; } = new List<ILectureResource>(); //TODO: CHECK 

        public override string ToString()
        {
            return ConstructsOutput.LectureOutput(this);
        }
    }
}
