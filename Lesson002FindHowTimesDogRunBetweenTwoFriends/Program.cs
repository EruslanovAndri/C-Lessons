int count = 0;
double distance = 10000;
int firstFriendSpeed = 2;
int secondFriendSpeed = 3;
int dogSpeed = 5;
int meetingPoint = 10;
int friend = 2;
double time = 0;

if (distance > meetingPoint && friend != 2)
{
    time = distance / (secondFriendSpeed + dogSpeed);
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    friend = 1;
    count++;
}
else
{
    time = distance / (firstFriendSpeed + dogSpeed);
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    friend = 2;
    count++;
}

Console.WriteLine($"{count}");




// Do not work





