using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Domain.Role
{
    public sealed class RoleList
    {
        public static List<AppRole> GetStaticRoles()
        {
            List<AppRole> appRoles = new List<AppRole>();

            #region UCAF
            appRoles.Add(new AppRole(
                title: UCAF,
                code: UCAFCreateCode,
                name: UCAFCreateName));

            appRoles.Add(new AppRole(
                title: UCAF,
                code: UCAFUpdateCode,
                name: UCAFUpdateName));

            appRoles.Add(new AppRole(
                title: UCAF,
                code: UCAFRemoveCode,
                name: UCAFRemoveName));

            appRoles.Add(new AppRole(
                title: UCAF,
                code: UCAFReadCode,
                name: UCAFReadName));
            #endregion

            return appRoles;
        }

        #region RoleCodeAndNames
        public static string UCAFCreateCode = "UCAF.Create";
        public static string UCAFCreateName = "Hesap Planı Kayıt";

        public static string UCAFUpdateCode = "UCAF.Update";
        public static string UCAFUpdateName = "Hesap Planı Güncelle";

        public static string UCAFRemoveCode = "UCAF.Remove";
        public static string UCAFRemoveName = "Hesap Planı Sil";

        public static string UCAFReadCode = "UCAF.Read";
        public static string UCAFReadName = "Hesap Planı Görüntüle";
        #endregion

        #region RoleTitleNames
        public static string UCAF = "Hesap Planı";
        #endregion
    }
}
