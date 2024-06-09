﻿using Application.BusinessLogic.Core;
using Application.BusinessLogic.Interfaces;
using Application.Domain.Entities.Job;
using Application.Domain.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogic
{
    public class JobBL : IJob
    {
        private readonly JobApi jobApi;

        public JobBL()
        {
            this.jobApi = new JobApi();
        }

        public Job GetJobByIdAction(int Id)
        {
            return jobApi.GetJobByIdService(Id);
        }

        public List<JobApplication> GetJobApplicationAction(int jobId)
        {
            return jobApi.GetJobApplycations(jobId);
        }

        public SimpleResponse ApplyToJobAction(int jobId, string email)
        {
            return jobApi.ApplyToJobService(jobId, email);
        }

        public CreateJobResponse CreateJobAction(Job data, string ownerEmail)
        {
            return jobApi.CreateJobService(data, ownerEmail);
        }

        public List<Job> GetJobs(JobFilters filter)
        {
            return jobApi.GetJobsService(filter);
        }

        public List<Job> GetUserJobs(string email)
        {
            return jobApi.GetUserJobsService(email);
        }
    }
}
