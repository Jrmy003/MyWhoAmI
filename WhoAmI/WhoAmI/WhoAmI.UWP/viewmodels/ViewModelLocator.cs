using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace WhoAmI.UWP.viewmodels
{
    class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<NewCharacterViewModel>();
        }
        public NewCharacterViewModel CharacterViewModel
        {
            get { return ServiceLocator.Current.GetInstance<NewCharacterViewModel>(); }
        }
    }
}
