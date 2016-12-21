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
        public NewCharacterViewModel NewCharacterViewModel
        {
            get { return ServiceLocator.Current.GetInstance<NewCharacterViewModel>(); }
        }

        public CharactersViewModel CharactersViewModel
        {
            get { return ServiceLocator.Current.GetInstance<CharactersViewModel>(); }
        }
    }
}
