Console.Clear();

int count = 0;
int firstFriendSpeed = 3;
int secondFriendSpeed = 2;
int dogSpeed = 1;
int distance = 40;
int friend = 2;
int meetingPoint = 10;
int time = 0;


while( distance > meetingPoint)
{
    if(friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 2;
        distance = distance - (firstFriendSpeed - secondFriendSpeed) * time;
        
        
    }
    else if (friend == 1)
    {
        time = distance / (firstFriendSpeed - dogSpeed);
        friend = 1;
        distance = distance - (firstFriendSpeed - secondFriendSpeed) * time;
        
    }
    time = 0;
    count = count + 1;
}
Console.WriteLine(count);


// Work!