using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using WhoAmI.UWP.views;

namespace WhoAmI.UWP.viewmodels
{
    class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SetupNavigation();

            SimpleIoc.Default.Register<NewCharacterViewModel>();
            SimpleIoc.Default.Register<CharactersViewModel>();
            SimpleIoc.Default.Register<MainPageViewModel>();
        }
        public NewCharacterViewModel NewCharacterViewModel
        {
            get { return ServiceLocator.Current.GetInstance<NewCharacterViewModel>(); }
        }

        public CharactersViewModel CharactersViewModel
        {
            get { return ServiceLocator.Current.GetInstance<CharactersViewModel>(); }
        }

        public MainPageViewModel MainPageViewModel
        {
            get { return ServiceLocator.Current.GetInstance<MainPageViewModel>(); }
        }

        private void SetupNavigation()
        {
            var navigationService = new NavigationService();
            navigationService.Configure("MainView", typeof(MainView));
            navigationService.Configure("NewCharacterView", typeof(NewCharacterView));
            navigationService.Configure("CharactersView", typeof(CharactersView));

            SimpleIoc.Default.Register<INavigationService>(() => navigationService);
        }
    }
}
