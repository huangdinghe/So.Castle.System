using System.Collections.Generic;
using NHibernate.Criterion;
using So.Castle.Component;
using So.Castle.Domain;
using So.Castle.Manager;
using So.Castle.Service;

namespace ZDSoft.LMS.Component
{
    public class UsersComponent : BaseComponent<Users, UsersManager>, IUsersService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account">操作员输入的用户名</param>
        /// <param name="password">操作员输入的密码</param>
        /// <returns>当用户名和密码成功匹配时返回匹配的用户信息，否则返回null</returns>
        public Users Login(string account, string password)
        {
            //组织查询条件(标准条件查询)
            IList<NHibernate.Criterion.ICriterion> criterionList = new List<ICriterion>();
            //向条件集合添加查询条件，每个条件之间默认为And关系，从数据库中查询同时满足3个条件的用户信息
            criterionList.Add(NHibernate.Criterion.Expression.Eq("Account", account));
            criterionList.Add(Expression.Eq("Password", password));
            criterionList.Add(Expression.Eq("IsActive", true));

            //调用数据访问层的方法执行操作            
            Users user = manager.Get(criterionList);
            return user;
        }

        /// <summary>
        /// 帐号重复性检测
        /// </summary>
        /// <param name="id">帐号对应的ID值</param>
        /// <param name="account">要判断的帐号名</param>
        /// <returns></returns>
        public bool AccountCheck(int? id, string account)
        {
            //组织参数条件
            IList<ICriterion> criterionList = new List<ICriterion>();
            criterionList.Add(Expression.Eq("Account", account));
            //判断id是否值大于0，如果是则说明是修改时做判断
            if (id.HasValue && id.Value > 0)
            {
                //criterionList.Add(Expression.Not(Expression.Eq("ID", id.Value)));
                ICriterion criterion = Expression.Eq("ID", id.Value);
                criterionList.Add(Expression.Not(criterion));
            }

            //执行查询操作
            return this.Exists(criterionList);

        }




        /// <summary>
        /// 通过ID删除
        /// </summary>
        /// <param name="id"></param>
        public new void Delete(int id)
        {
            manager.Delete(id);
        }

        /// <summary>
        /// 通过对象删除
        /// </summary>
        /// <param name="users"></param>
        public new void Delete(Users users)
        {
            manager.Delete(users);
        }
    }
}
