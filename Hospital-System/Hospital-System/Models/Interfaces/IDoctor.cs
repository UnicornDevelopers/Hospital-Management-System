using Hospital_System.Models.DTOs;

namespace Hospital_System.Models.Interfaces
{
    public interface IDoctor
    {
        Task<DoctorDTO> Create(DoctorDTO doctor);

        // GET All
        Task<List<DoctorDTO>> GetDoctors();

        // GET Hotel By Id

        Task<DoctorDTO> GetDoctor(int DoctorID);

        // Update
        Task<DoctorDTO> UpdateDoctor(int id, DoctorDTO DoctorDTO);

        // Delete 

        Task Delete(int id);


    }
}
