﻿namespace Academy.Core.Factories
{
    using System;

    using Academy.Core.Contracts;
    using Academy.Core.Providers;
    using Academy.Models;
    using Academy.Models.Academy_Staff;
    using Academy.Models.Contracts;
    using Academy.Models.Enums;
    using Academy.Models.Resource;
    using Academy.Models.Syllabus;
    using Academy.Models.Utils.Contracts;

    public class AcademyFactory : IAcademyFactory
    {
        private static IAcademyFactory instanceHolder = new AcademyFactory();

        // private because of Singleton design pattern
        private AcademyFactory()
        {
        }

        public static IAcademyFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public ISeason CreateSeason(string startingYear, string endingYear, string initiative)
        {
            var parsedStartingYear = int.Parse(startingYear);
            var parsedEngingYear = int.Parse(endingYear);

            Initiative parsedInitiativeAsEnum;
            Enum.TryParse<Initiative>(initiative, out parsedInitiativeAsEnum);

            return new Season(parsedStartingYear, parsedEngingYear, parsedInitiativeAsEnum);
        }

        public IStudent CreateStudent(string username, string track)
        {
            return new Student(username, track);
        }

        public ITrainer CreateTrainer(string username, string technologies)
        {
            return new Trainer(username, technologies);
        }

        public ICourse CreateCourse(string name, string lecturesPerWeek, string startingDate)
        {
            return new Course(name, lecturesPerWeek, startingDate);
        }

        public ILecture CreateLecture(string name, string date, ITrainer trainer)
        {
            return new Lecture(name, date, trainer);
        }

        public ILectureResouce CreateLectureResouce(string type, string name, string url)
        {
            // Use this instead of DateTime.Now if you want any points in BGCoder!!
            var currentDate = DateTimeProvider.Now;
            ILectureResouce Resource;

            switch (type)
            {
                case "video":
                    Resource = new VideoResource(name, url, currentDate);
                    break;
                case "presentation":
                    Resource = new PresentationResource(name, url);
                    break;
                case "demo":
                    Resource = new DemoResource(name, url);
                    break;
                case "homework":
                    Resource = new HomeworkResource(name, url, currentDate);
                    break;
                default: throw new ArgumentException("Invalid lecture resource type");
            }
            return Resource;
            //            switch (type)
            //            {
            //                case "video": return new VideoResource(name, url, currentDate);
            //                case "presentation": return new PresentationResource(name, url);
            //                case "demo": return new DemoResource(name, url);
            //                case "homework": return new HomeworkResource(name, url, currentDate);
            //                default: throw new ArgumentException("Invalid lecture resource type");
            //            }
        }

        public ICourseResult CreateCourseResult(ICourse course, string examPoints, string coursePoints)
        {
            return new CourseResult(course, examPoints, coursePoints);
        }
    }
}
