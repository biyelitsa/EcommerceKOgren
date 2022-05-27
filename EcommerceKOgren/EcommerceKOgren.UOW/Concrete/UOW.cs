using EcommerceKOgren.DataAccess.Abstract;
using EcommerceKOgren.DataAccess.Concrete;
using EcommerceKOgren.UOW.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.UOW.Concrete
{
    public class UOW : IUOW
    {
        Context _db;
        public ICategoryDal _catRepos { get;  set; }
        public ICityDal _cityRepos { get;  set; }
        public ICountyDal _countyRepos { get; set; }
        public ICountryDal _countryRepos { get; set; }
        public IFilterDal _filterRepos { get;  set; }
        public IColorDal _colorRepos { get;  set; }
        public ICustomerDal _customRepos { get; set; }
        public IOrderDal _orderRepos { get;  set; }
        public IOrderDetailDal _orderDetailRepos { get;  set; }
        public IProductDal _proRepos { get;  set; }
        public ISizeDal _sizeRepos { get;  set; }
        public ISupplierDal _supRepos { get;  set; }
        public IUnitDal _unitRepos { get;  set; }
        public IEmployeeDal _employeeRepos { get;  set; }
        public UOW
        (
            Context db,
            ICategoryDal catRepos,
            ICityDal cityRepos,
            ICountyDal countyRepos,
            ICountryDal countryRepos,
            IFilterDal filterRepos,
            IColorDal colorRepos,
            ICustomerDal customRepos,
            IOrderDal orderRepos,
            IOrderDetailDal orderDetailRepos,
            IProductDal proRepos,
            ISizeDal sizeRepos,
            ISupplierDal supRepos,
            IUnitDal unitRepos,
            IEmployeeDal employeeRepos
        )
        {
            _db = db;
            _catRepos = catRepos;
            _cityRepos = cityRepos;
            _countyRepos = countyRepos;
            _countryRepos = countryRepos;
            _filterRepos = filterRepos;
            _colorRepos = colorRepos;
            _customRepos = customRepos;
            _orderRepos = orderRepos;
            _orderDetailRepos = orderDetailRepos;
            _proRepos = proRepos;
            _sizeRepos = sizeRepos;
            _supRepos = supRepos;
            _unitRepos = unitRepos;
            _employeeRepos = employeeRepos;
        }
        
        public void Commit()
        {
            _db.SaveChanges();
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
