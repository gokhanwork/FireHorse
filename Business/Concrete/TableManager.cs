using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TableManager : ITableService
    {
        ITableDal _tableDal;

        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }

        [SecuredOperation("table.add,admin")]
        //[ValidationAspect(typeof(TableValidator))]
        //[CacheRemoveAspect("ITableService.Get")]
        public IResult Add(Table table)
        {
            IResult result = BusinessRules.Run(CheckIfTableNameExists(table.TableName));
            if (result != null)
            {
                return result;
            }
            _tableDal.Add(table);
            return new SuccessResult(Messages.TableAdded);
        }

        private IResult CheckIfTableNameExists(string tableName)
        {
            var result = _tableDal.GetAll(t => t.TableName == tableName).Any();
            if (result)
            {
                return new ErrorResult(Messages.TableNameAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<List<Table>> GetAll()
        {
            return new SuccessDataResult<List<Table>>(_tableDal.GetAll(), Messages.TableListed);
        }

        public IResult Update(Table table)
        {
            throw new NotImplementedException();
        }
    }
}
