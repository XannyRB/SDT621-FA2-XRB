#include <vector>
#include <iostream>

int main (){
    std::vector<int> scores;
    int input;

    std::cout << "Enter scores (-1 to stop):\n";

    while (true){
        std::cin >> input;
        if (input == -1) break;
        scores.push_back(input);
    }

    int sum = 0;

    for (int i = 0; i < scores.size(); i++){
        sum += scores[i];
    }

    double average = (scores.size()> 0) ? (double)sum / scores.size() : 0;

    std::cout << "\nYou Entered " << scores.size() << " scores.\n";
    std::cout << "Average score: "<< average << "\n";
    return 0;
}

