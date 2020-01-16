using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEntities
{
    public class SQlManageUsers
    {
        private readonly p1_cnx_sqlEntities Context = new p1_cnx_sqlEntities();

        public IList GetUserData()
        {
            var employee = from u in Context.users
                           join s in Context.users on u.supervisor equals s.empno
                           select new
                           {
                               ID = u.empno,
                               Name = u.empname,
                               Supervisor = s.empname,
                               Department = u.departement.depname,
                               Salary = u.salaire,
                               Birthdate = u.datenaiss,
                               Gender = (bool)u.sexe ? "Male" : "Femmale"
                           };

            return employee.ToList();
        }

        public IList GetDepartmentData()
        {
            return Context.departements.ToList();
        }

        public void InsertUser(user user)
        {
            user.empno = Context.users.AsEnumerable().LastOrDefault().empno + 1;
            Context.users.Add(user);
            Context.SaveChanges();
        }

        public void UpdateUser(user user, int departmentId)
        {
            var employee = Context.users.SingleOrDefault(e => e.empno == user.empno);

            employee.empname = user.empname;
            employee.deptno = user.deptno;
            employee.supervisor = user.supervisor;
            employee.job = user.job;
            employee.salaire = user.salaire;
            employee.datenaiss = user.datenaiss;
            employee.sexe = user.sexe;
            employee.civilite = user.civilite;
            employee.departement = Context.departements.SingleOrDefault(d => d.IDDEP == departmentId);


            Context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = Context.users.SingleOrDefault(e => e.empno == id);

            Context.users.Remove(user);
            Context.SaveChanges();
        }

        public void DeleteMulti(params int[] ids)
        {
            var users = Context.users.Where(u => ids.Contains(u.empno)).ToList();

            Context.users.RemoveRange(users);
            Context.SaveChanges();
        }

        public IList SearchForUsers(string name, string supervisor, string department)
        {
            var employees = from u in Context.users.ToList()
                            join s in Context.users on u.supervisor equals s.empno
                            where u.empname.StartsWith(name) && s.empname.StartsWith(supervisor) && u.departement.depname.StartsWith(department)
                            select new
                            {
                                ID = u.empno,
                                Name = u.empname,
                                Supervisor = s.empname,
                                Department = u.departement.depname,
                                Salary = u.salaire,
                                Birthdate = u.datenaiss,
                                Gender = u.sexe
                            };

            return employees.ToList();
        }
    }
}
