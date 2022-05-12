using AutoMapper;
using ControleFinanceiro.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Application
{
    public class ApplicationServiceBase<T, TD> 
        where T : class
        where TD : class
    {
        private IMapper mapper;
        private IUnitOfWork uow;
        private IServiceBase<T> service;

        public ApplicationServiceBase(IMapper mapper, IUnitOfWork uow, IServiceBase<T> service)
        {
            this.mapper = mapper;
            this.uow = uow;
            this.service = service;
        }

        public async Task<TD> Save(TD entity) {
            this.BeginTransaction();

            var model = this.MapperDtoToDomain(entity);
            var result = await this.service.Save(model);

            await this.CommitAsync();
            return this.MapperDomainToDto(result);

        }

        public async Task<TD> SavePartial(TD entity) {
            this.BeginTransaction();

            var model = this.MapperDtoToDomain(entity);
            var result = await this.service.SavePartial(model);

            await this.CommitAsync();
            return this.MapperDomainToDto(result);
        }

        public async Task<int> Remove(TD entity) {
            this.BeginTransaction();
            var model = this.MapperDtoToDomain(entity);
            await this.service.Remove(model);

            return await this.CommitAsync();
        }

        public void BeginTransaction()
        {
            this.uow.BeginTransaction();
        }

        public int Commit()
        {
            return this.uow.Commit();
        }

        public async Task<int> CommitAsync()
        {
            return await this.uow.CommitAsync();
        }


        private T MapperDtoToDomain(TD entity)
        {
            return this.mapper.Map<TD, T>(entity);
        }

        private TD MapperDomainToDto(T entity)
        {
            return this.mapper.Map<T, TD>(entity);
        }
    }
}
