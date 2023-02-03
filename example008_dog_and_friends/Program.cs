int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int Time = 0;

if(distance < 10)
{
    Console.Write(count);
}
if(distance > 10)
{
    while(10 < distance)
    {

        if(friend == 1)
            {
                Time = distance / (firstFriendSpeed + dogSpeed);
                friend = 2;
                distance = distance - (firstFriendSpeed + SecondFriendSpeed);
                count= count + 1;
        
            }
        if(friend != 1)
            {
                Time = distance / (SecondFriendSpeed + dogSpeed);
                friend = 1;
                distance = distance - (firstFriendSpeed + SecondFriendSpeed);
                count = count + 1;
            }
    Console.WriteLine(count);        
    }
    
}
