int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int distance = 10000;
int distanceMin = 10;
double timeToMeet = 0;

int friend = 2;
int count = 0;
double distanceBetweenFriends = distance;

while (distanceBetweenFriends > distanceMin) {
    if (friend == 2) {
        timeToMeet = distanceBetweenFriends / (secondFriendSpeed + dogSpeed);
        friend = 1;
    } else {
        timeToMeet = distanceBetweenFriends / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    distanceBetweenFriends -= timeToMeet * (firstFriendSpeed + secondFriendSpeed);
    count ++;
}
Console.WriteLine(count);
 