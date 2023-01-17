using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.SQL;
using Model.Entities;
using Model.Processors;


namespace Controllers.MainPart
{
    public class UserController
    {
        public UserController(Int32 id)
        {
            _user = _queryHandler.GetEntityById(id);
            AccountController = new AccountController(id);
            AllImagesController = new ImagesController();
            SingleImageController = new ImagesController();
        }

        // Add
        public AddResult AddNewConnection()
        {
            Int32 userId = _user.UserId;
            Int32 imageId = AllImagesController.GetCurrentId();

            if (_udiHandler.FindUserDesktopImageById(userId, imageId) != -1)
            {
                return AddResult.Entity_already_exists;
            }

            _udiHandler.AddUserDesktopImage(new UserDesktopImage()
            {
                UserId = userId,
                DesktopImageId = imageId,
                AddDate = DateTime.Now,
            });

            return AddResult.Success;
        }

        // Update
        public AccountUpdateResult ChangeUser(String login, String password, String email,
            String name, String surname, DateTime birthDate)
        {
            AccountUpdateResult accountChangeResult = AccountController
                .UpdateAccount(login, password, email);

            if (accountChangeResult == AccountUpdateResult.Success)
            {
                _user.UserName = name;
                _user.UserSurname = surname;
                _user.UserBirthDate = birthDate;
                
                _queryHandler.UpdateUser(_user);
            }

            return accountChangeResult;
        }

        // Delete 
        public DeleteResult DeleteCurrentConnection()
        {
            try
            {
                _udiHandler.DeleteUserDesktopImage(
                    _udiHandler.GetEntityById(
                        _udiHandler.FindUserDesktopImageById(
                            _user.UserId, SingleImageController.GetCurrentId())));

                return DeleteResult.Success;
            }
            catch
            {
                return DeleteResult.Failure;
            }
        }

        public void SetRating(Int32 rating)
        {
            if (rating <= 0 || rating > 5)
            {
                return;
            }

            Int32 imageId = SingleImageController.GetCurrentId();

            if (imageId == -1)
            {
                return;
            }
            try
            { 
                _udiHandler.UpdateRating(_user.UserId, imageId, rating);
            }
            catch
            {

            }
        }

        // Get
        public Int32 GetId()
        {
            return _user.UserId;
        }
        public String GetName()
        {
            return _user.UserName;
        }
        public String GetSurname()
        {
            return _user.UserSurname;
        }
        public DateTime GetBirthDate()
        {
            return _user.UserBirthDate;
        }

        public DateTime GetImageAddDateForUser()
        {
            Int32 imageId = SingleImageController.GetCurrentId();

            if (imageId == -1)
            {
                return DateTime.MinValue;
            }

            return _udiHandler.GetEntityById(
                _udiHandler.FindUserDesktopImageById(_user.UserId, imageId)).AddDate;
        }
        public Int32 GetImageRatingForUser()
        {
            Int32 imageId = SingleImageController.GetCurrentId();

            if (imageId == -1)
            {
                return 0;
            }

            return _udiHandler.GetEntityById(
                _udiHandler.FindUserDesktopImageById(_user.UserId, imageId)).Rating;
        }

        // Filtering
        public void MakeImagesSortedAndFiltered(IEnumerable<String> lables, String sortFilter, 
            Boolean isAsc, String title)
        {
            if (lables.Count() != 0)
            {
                AllImagesController.FilterImages(lables);
            }
            else 
            {
                AllImagesController.UpdateImagesByTitle(title);
            }

            AllImagesController.SortImages(sortFilter, isAsc);

        }
        
        public void UpdateUserOnlyImages()
        {
            SingleImageController.UpdateImagesByUserId(GetId());
        }

        public SetResult SetCurrentAsImage(String style)
        {
            ImageDesktopSetter imageDesktopSetter =
                new ImageDesktopSetter(SingleImageController
                .GetCurrentSelected(), SingleImageController.GetCurrentTitle(), 
                SingleImageController.GetCurrentFormat());

            return imageDesktopSetter.SetWallpaper(style);
        }

        public AccountController AccountController;
        public ImagesController AllImagesController;
        public ImagesController SingleImageController;
        
        private AppUser _user;

        private UserQuery _queryHandler = new UserQuery();
        private UserDesktopImageQuery _udiHandler = new UserDesktopImageQuery();
    }
}
