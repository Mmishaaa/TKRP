using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class PingPongTableService : GenericService<PingPongTableModel, PingPongTableEntity>, IPingPongTableService
    {
        public PingPongTableService(IPingPongTableRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

    }
}
