#include <iostream>
#include <fstream>
#include <string>
#include <windows.h>
#include <conio.h>

using namespace std;

const string PASSWORD_FILE = "lockinfo.dat";

// Function to hash the password (simple hash for demonstration)
string hashPassword(const string& password)
{
    unsigned int hash = 0;
    for (char ch : password)
    {
        hash = (hash * 31) + ch;
    }
    return to_string(hash);
}

// Function to save the hashed password
void savePassword(const string& hashedPassword)
{
    ofstream file(PASSWORD_FILE);
    if (file.is_open())
    {
        file << hashedPassword;
        file.close();
    }
}

// Function to read stored password hash
string getStoredPassword()
{
    ifstream file(PASSWORD_FILE);
    string storedHash;
    if (file.is_open())
    {
        getline(file, storedHash);
        file.close();
    }
    return storedHash;
}

// Function to check if folder is locked
bool isFolderLocked(const string& folderPath)
{
    DWORD attributes = GetFileAttributes(folderPath.c_str());
    return (attributes != INVALID_FILE_ATTRIBUTES && (attributes & FILE_ATTRIBUTE_HIDDEN));
}

// Function to lock the folder
void lockFolder(const string& folderPath, const string& password)
{
    string hashedPassword = hashPassword(password);
    savePassword(hashedPassword);

    if (SetFileAttributes(folderPath.c_str(), FILE_ATTRIBUTE_HIDDEN | FILE_ATTRIBUTE_SYSTEM))
    {
        cout << "Folder locked successfully!\n";
    }
    else
    {
        cout << "Failed to lock the folder. Please check the path.\n";
    }
}

// Function to unlock the folder
void unlockFolder(const string& folderPath, const string& password)
{
    string storedHash = getStoredPassword();
    string hashedPassword = hashPassword(password);

    if (storedHash.empty())
    {
        cout << "No stored password found. Folder might not be locked.\n";
        return;
    }

    if (hashedPassword != storedHash)
    {
        cout << "Incorrect password! Folder remains locked.\n";
        return;
    }

    if (SetFileAttributes(folderPath.c_str(), FILE_ATTRIBUTE_NORMAL))
    {
        cout << "Folder unlocked successfully!\n";
        remove(PASSWORD_FILE.c_str());  // Remove password file after unlocking
    }
    else
    {
        cout << "Failed to unlock the folder. Please check the path.\n";
    }
}

// Securely input password (masking characters)
string getPasswordInput()
{
    string password;
    char ch;
    cout << "Enter password: ";
    while ((ch = _getch()) != 13)
    {  // Enter key (ASCII 13) to finish
        if (ch == 8 && !password.empty())
        {  // Handle backspace
            password.pop_back();
            cout << "\b \b";
        }
        else if (ch != 8)
        {
            password.push_back(ch);
            cout << '*';  // Mask input
        }
    }
    cout << endl;
    return password;
}

int main()
{
    string folderPath, password;
    int choice;

    cout << "Folder Locking System\n";
    cout << "1. Lock Folder\n";
    cout << "2. Unlock Folder\n";
    cout << "3. Exit\n";
    cout << "Enter your choice: ";
    cin >> choice;
    cin.ignore();

    switch (choice)
    {
        case 1:
            cout << "Enter the folder path to lock: ";
            getline(cin, folderPath);
            password = getPasswordInput();
            lockFolder(folderPath, password);
            break;

        case 2:
            cout << "Enter the folder path to unlock: ";
            getline(cin, folderPath);
            password = getPasswordInput();
            unlockFolder(folderPath, password);
            break;

        case 3:
            cout << "Exiting program.\n";
            return 0;

        default:
            cout << "Invalid choice! Try again.\n";
    }

    return 0;
}
