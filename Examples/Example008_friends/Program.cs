// Задача про друзей
    int distance = 10000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5,
    time = 0,
    friend = 2;
    
int count = 0;

    while(distance > 10)
    {
            if(friend != 1)
        {
            time = distance / (secondFriendSpeed + dogSpeed);
            friend = 1;
        }
            else
        {
            time = distance / (firstFriendSpeed + dogSpeed);
            friend = 2;   
        }
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
Console.WriteLine(count);