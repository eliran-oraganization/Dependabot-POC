using Legit.Common.Domain;
using Legit.Common.License.Clients;

namespace WebApplication1;

public class MyClass
{
    public ScmType ScmType = ScmType.Artifactory;
    public UserManagementConfiguration User;

    public MyClass(UserManagementConfiguration user)
    {
        User = user;
    }
}