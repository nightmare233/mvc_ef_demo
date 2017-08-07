using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Model;
using Company.IBLL;
using Company.IDAL;

namespace Company.BLL
{
    public partial class DepartmentService : BaseService<Department>, IDepartmentService
    {
        private IDepartmentDAL DepartmentDAL = DALContainer.Container.Resolve<IDepartmentDAL>();

        public override void SetDal()
        {
            Dal = DepartmentDAL;
        }
    }
}
