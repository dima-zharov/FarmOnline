public class Registration : EntryPattern
{
    protected override string ReturnUrl() =>
        $"https://zetprime.pythonanywhere.com/game/api/registration?email={_userEmail}&password={_userPassword}";
}
