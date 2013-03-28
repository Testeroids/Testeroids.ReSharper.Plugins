using System.Windows.Forms;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;

namespace Testeroids.PrivateWatchDog
{
  [ActionHandler("Testeroids.PrivateWatchDog.About")]
  public class AboutAction : IActionHandler
  {
    public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
    {
      // return true or false to enable/disable this action
      return true;
    }

    public void Execute(IDataContext context, DelegateExecute nextExecute)
    {
      MessageBox.Show(
        "Private WatchDog\nTesteroids\n\nComplains whenever a private field or property is being accessed in a nested Context test class",
        "About Private WatchDog",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
    }
  }
}
