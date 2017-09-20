
function CommonInit()
{
    $('#content').fadeIn('slow');
    $('#tdResults').animate({ 'padding-top': '-50px' }, 1000);
}

function MainMenu()
{
    window.location.href = 'index.htm';
}

function CalorieCalculator()
{
    window.location.href = 'calorie_calc_angularjs.htm';
}

function FoodListing()
{
}

function DietProgression()
{
}

function DailyMenu()
{
}

function SaveData(key, value)
{
    localStorage.setItem(key, value);
}

function LoadData(key)
{
    return localStorage.getItem(key);
}
