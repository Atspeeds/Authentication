namespace _01_Framework.Application
{
    public class ActionResponse
    {
        public bool successful { get; set; }
        public string Message { get; set; }

        public ActionResponse Success(string message = "عملیات با موفقیت انجام شد")
        {
            successful = true;
            Message= message;
            return this;
        }
        public ActionResponse Failed(string message)
        {
            Message = message;
            successful = false;
            return this;
        }



    }
}
