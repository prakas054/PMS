using PMS.BusinessLayer.Business.Interface;
using PMS.BusinessLayer.DTO;
using PMS.DAL.Entity;
using PMS.DAL.UnitOfWork.Implementation;
using PMS.DAL.UnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.Business.Implementation
{
    public class AppointmentBusiness : IAppointmentBusiness
    {
        private readonly IUnitOfWork _unitOfWork;
        public AppointmentBusiness(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public IEnumerable<AppointmentDTO> GetAllAppointment()
        {
            var app = _unitOfWork.AppointmentRepository.GetAll().ToList();

            return GetAppointmrentDTO(app);
        }

        public void AddAppointment(AppointmentDTO appointmentDTO)
        {
            _unitOfWork.AppointmentRepository.Add(GetAppointment(appointmentDTO));
            _unitOfWork.Complete();
        }

        private List<AppointmentDTO> GetAppointmrentDTO(List<Appointment> appointments)
        {
            List<AppointmentDTO> appointmentDTOs = new List<AppointmentDTO>();

            foreach (var item in appointments)
            {
                appointmentDTOs.Add(new AppointmentDTO
                {
                    AppointmentId = item.Appointment_Id,
                    Title = item.Title,
                    AppointmentDate = item.Appointment_Date,
                    AppointmentTime = item.Appointment_Time,
                    Reason = item.Reason,
                    SchedularId = item.Schedular_Id,
                    PhysicianId = item.Physician_Id,
                    NurseId = item.Nurse_Id,
                    PatientId = item.Patient_Id
                });
            }

            return appointmentDTOs;
        }

        private Appointment GetAppointment(AppointmentDTO appointmentDTO)
        {
            return new Appointment
            {
                Title = appointmentDTO.Title,
                Appointment_Date = appointmentDTO.AppointmentDate,
                Appointment_Time = appointmentDTO.AppointmentTime,
                Reason = appointmentDTO.Reason,
                Schedular_Id = appointmentDTO.SchedularId,
                Physician_Id = appointmentDTO.PhysicianId,
                Nurse_Id = appointmentDTO.NurseId,
                Patient_Id = appointmentDTO.PatientId
            };
        }
    }
}
