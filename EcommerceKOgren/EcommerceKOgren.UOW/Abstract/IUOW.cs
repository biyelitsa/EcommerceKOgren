using EcommerceKOgren.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.UOW.Abstract
{
    public interface IUOW
    {
        ICategoryDal _catRepos { get; }
        ICityDal _cityRepos { get; }
        ICountyDal _countyRepos { get; }
        ICountryDal _countryRepos { get; }
        IFilterDal _filterRepos { get; }
        IColorDal _colorRepos { get; }
        ICustomerDal _customRepos { get; }
        IOrderDal _orderRepos { get; }
        IOrderDetailDal _orderDetailRepos { get; }
        IProductDal _proRepos { get; }
        ISizeDal _sizeRepos { get; }
        ISupplierDal _supRepos { get; }
        IUnitDal _unitRepos { get; }
        IEmployeeDal _employeeRepos { get; }
        void Commit();
        void Dispose();
    }
}
