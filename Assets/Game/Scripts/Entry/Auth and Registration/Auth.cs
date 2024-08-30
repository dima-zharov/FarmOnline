public class Auth : EntryPattern
{
    protected override string ReturnUrl() =>
        $"https://zetprime.pythonanywhere.com/game/api/login?email={_userEmail}&password={_userPassword}";

}
