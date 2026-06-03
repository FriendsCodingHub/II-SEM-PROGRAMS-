# **UNIX LAB**
# **PART - A**

(Questions 1 to 10)

# 1. Write a UNIX command to create a directory, change a directory and remove directory.

### 1. mkdir (Make Directory)

**Command:**
```bash
mkdir dirname
```

**Description:**
Creates a new directory with the specified name.

**Example:**
```bash
mkdir test
```

---

### 2. cd (Change Directory)

**Command:**
```bash
cd dirname
```

**Description:**
Changes the current working directory to the specified directory.

**Example:**
```bash
cd test
```

---

### 3. rmdir (Remove Directory)

**Command:**
```bash
rmdir dirname
```

**Description:**
Removes an empty directory from the system.

**Example:**
```bash
rmdir test
```


# 2. Write a UNIX command to display date with various options.

# Common date Format Options

| Option | Description |
|----------|-------------|
| %a | Abbreviated weekday name (Sun) |
| %A | Full weekday name (Sunday) |
| %b | Abbreviated month name (Jan) |
| %B | Full month name (January) |
| %c | Complete date and time |
| %d | Day of month (01-31) |
| %D | Date as MM/DD/YY |
| %F | Date as YYYY-MM-DD |
| %H | Hour (00-23) |
| %I | Hour (01-12) |
| %j | Day of year (001-366) |
| %m | Month (01-12) |
| %M | Minute (00-59) |
| %p | AM or PM |
| %r | Time in 12-hour format |
| %S | Seconds (00-59) |
| %T | Time as HH:MM:SS |
| %u | Day of week (1-7) |
| %U | Week number of year |
| %w | Day of week (0-6) |
| %x | Local date representation |
| %X | Local time representation |
| %y | Year (last two digits) |
| %Y | Year (four digits) |
| %Z | Time zone name |
| %% | Displays % character |

### Command: date

**Description:**
The `date` command is used to display or set the system date and time. It can display the date in various formats using different options.

---

### 1. Display Current Date and Time

**Command:**
```bash
date
```

**Description:**
Displays the current system date and time.

---

### 2. Display Date in DD/MM/YY Format

**Command:**
```bash
date +"%d/%m/%y"
```

**Description:**
Displays the date in day/month/year format.

---

### 3. Display Date in DD-MM-YYYY Format

**Command:**
```bash
date +"%d-%m-%Y"
```

**Description:**
Displays the date in day-month-year format.

---

### 4. Display Only Day

**Command:**
```bash
date +"%d"
```

**Description:**
Displays the current day of the month.

---

### 5. Display Only Month

**Command:**
```bash
date +"%m"
```

**Description:**
Displays the current month.

---

### 6. Display Only Year

**Command:**
```bash
date +"%Y"
```

**Description:**
Displays the current year.

---

### 7. Display Current Time

**Command:**
```bash
date +"%T"
```

**Description:**
Displays the current time in HH:MM:SS format.

---

### 8. Display Hour

**Command:**
```bash
date +"%H"
```

**Description:**
Displays the current hour.

---

### 9. Display Minutes

**Command:**
```bash
date +"%M"
```

**Description:**
Displays the current minutes.

---

### 10. Display Seconds

**Command:**
```bash
date +"%S"
```

**Description:**
Displays the current seconds.

---

### 11. Display Day Name

**Command:**
```bash
date +"%A"
```

**Description:**
Displays the full name of the current day.

---

### 12. Display Month Name

**Command:**
```bash
date +"%B"
```

**Description:**
Displays the full name of the current month.

---

### 13. Display Day of the Year

**Command:**
```bash
date +"%j"
```

**Description:**
Displays the day number within the year.

---

### 14. Display Week Number

**Command:**
```bash
date +"%U"
```

**Description:**
Displays the week number of the year.

---

### 15. Display Date and Time Together

**Command:**
```bash
date +"%d-%m-%Y %H:%M:%S"
```

**Description:**
Displays date and time in a customized format.


# 3. Write a UNIX command to display calendar with various options.

## Command: cal

**Description:**
The `cal` command is used to display a calendar in UNIX/Linux systems.

---

## Common cal Options

| Option | Description |
|----------|-------------|
| cal | Displays current month's calendar |
| cal month year | Displays calendar of specified month and year |
| cal year | Displays calendar of entire year |
| cal -1 | Displays current month calendar (default) |
| cal -3 | Displays previous, current and next month |
| cal -y | Displays complete calendar of current year |
| cal -m month | Displays specified month of current year |
| cal -A n | Displays n months after current month |
| cal -B n | Displays n months before current month |
| cal -j | Displays Julian calendar (day numbers) |
| cal -h | Hides highlighting of today's date |
| cal --help | Displays help information |
| cal --version | Displays version information |

---

## Executable Commands

### 1. Display Current Month Calendar

```bash
cal
```

Displays the current month's calendar.

---

### 2. Display Calendar of a Specific Month and Year

```bash
cal 6 2026
```

Displays June 2026 calendar.

---

### 3. Display Complete Calendar of a Year

```bash
cal 2026
```

Displays all months of the year 2026.

---

### 4. Display Current Year Calendar

```bash
cal -y
```

Displays the calendar for the current year.

---

### 5. Display Previous, Current and Next Month

```bash
cal -3
```

Displays three consecutive months.

---

### 6. Display Specific Month of Current Year

```bash
cal -m 12
```

Displays December of the current year.

---

### 7. Display Two Months Before Current Month

```bash
cal -B 2
```

Displays two months before the current month.

---

### 8. Display Two Months After Current Month

```bash
cal -A 2
```

Displays two months after the current month.

---

### 9. Display Two Months Before and After Current Month

```bash
cal -B 2 -A 2
```

Displays five months including the current month.

---

### 10. Display Julian Calendar

```bash
cal -j
```

Displays calendar with day numbers of the year.

---

### 11. Display Help Information

```bash
cal --help
```

Displays help for the cal command.

---

### 12. Display Version Information

```bash
cal --version
```

Displays the version of cal command.

# 4. Write a UNIX command to display time with various options.

## Command: date

**Description:**
The `date` command is used to display the current system time in various formats.

---

## Common Time Format Options

| Option | Description |
|----------|-------------|
| %H | Hour (00-23) |
| %I | Hour (01-12) |
| %M | Minutes (00-59) |
| %S | Seconds (00-59) |
| %p | AM/PM |
| %r | Time in 12-hour format |
| %R | Time in HH:MM format |
| %T | Time in HH:MM:SS format |
| %X | Local time representation |
| %Z | Time zone |
| %z | UTC offset |
| %N | Nanoseconds |
| %s | Seconds since Epoch |
| %k | Hour (0-23) |
| %l | Hour (1-12) |

---

## Executable Commands

### 1. Display Current Time

```bash
date +"%T"
```

Displays current time in HH:MM:SS format.

---

### 2. Display Time in HH:MM Format

```bash
date +"%R"
```

Displays hours and minutes.

---

### 3. Display Time in 12-Hour Format

```bash
date +"%r"
```

Displays time with AM/PM.

---

### 4. Display Hour Only

```bash
date +"%H"
```

Displays current hour.

---

### 5. Display Minutes Only

```bash
date +"%M"
```

Displays current minutes.

---

### 6. Display Seconds Only

```bash
date +"%S"
```

Displays current seconds.

---

### 7. Display Hour and Minutes

```bash
date +"%H:%M"
```

Displays hour and minutes.

---

### 8. Display Hour, Minutes and Seconds

```bash
date +"%H:%M:%S"
```

Displays complete time.

---

### 9. Display Time with AM/PM

```bash
date +"%I:%M:%S %p"
```

Displays time in 12-hour format with AM/PM.

---

### 10. Display Current Time Zone

```bash
date +"%Z"
```

Displays system time zone.

---

### 11. Display UTC Offset

```bash
date +"%z"
```

Displays UTC offset from GMT.

---

### 12. Display Local Time Representation

```bash
date +"%X"
```

Displays time according to locale settings.

---

### 13. Display Hour with Time Zone

```bash
date +"%H:%M:%S %Z"
```

Displays time along with time zone.

---

### 14. Display Epoch Time

```bash
date +"%s"
```

Displays seconds elapsed since January 1, 1970.

---

### 15. Display Nanoseconds

```bash
date +"%N"
```

Displays nanoseconds.

---

### 16. Display Complete Time Information

```bash
date +"%I:%M:%S %p %Z"
```

Displays time in 12-hour format along with AM/PM and time zone.


# 5. Write a UNIX command to display hours, minutes & seconds together.

## Command

```bash
date +"%H:%M:%S"
```

## Description

The `date` command is used to display the current system date and time. The format specifiers `%H`, `%M`, and `%S` display hours, minutes, and seconds respectively.

- `%H` → Hour (00-23)
- `%M` → Minutes (00-59)
- `%S` → Seconds (00-59)

## Example

```bash
date +"%H:%M:%S"
```

## Sample Output

```text
14:35:28
```

## Alternative Commands

### Display Time in 12-Hour Format

```bash
date +"%I:%M:%S %p"
```

### Display Time with Time Zone

```bash
date +"%H:%M:%S %Z"
```

### Display Complete Time Information

```bash
date +"%T"
```

`%T` is equivalent to `%H:%M:%S`.

# 6. Write a UNIX command to display list of users who are currently using Unix.

## Command

```bash
who
```

## Description

The `who` command displays the list of users who are currently logged into and using the UNIX system.

---

## Option: -a

```bash
who -a
```

**Description:**
Displays all available information including logged-in users, system boot time, run level, and login processes.

---

## Option: -H

```bash
who -H
```

**Description:**
Displays the list of logged-in users along with column headings.

## Example

```bash
who -H
```

## Sample Output

```text
NAME     LINE     TIME
student1 pts/0    Jun 03 10:15
student2 pts/1    Jun 03 11:20
```

# 7. Write a UNIX command to display your system details & user name.

## Command

```bash
uname -a
```

## Description

The `uname -a` command displays complete system information such as operating system name, kernel version, machine hardware name, processor type, and system architecture.

---

## Option: -a

```bash
uname -a
```

**Description:**
Displays all available system information.

---

## Option: -r

```bash
uname -r
```

**Description:**
Displays the kernel release version.

---

## Option: -m

```bash
uname -m
```

**Description:**
Displays the machine hardware architecture.

---

## Command

```bash
whoami
```

## Description

The `whoami` command displays the username of the currently logged-in user.

## Example

```bash
whoami
```

## Sample Output

```text
student
```

# 8. Write a UNIX command to list all the directories and files on the server.

## Command

```bash
ls
```

## Description

The `ls` command lists all files and directories in the current directory.

---

## Option: -a

```bash
ls -a
```

**Description:**
Displays all files and directories including hidden files.

---

## Option: -l

```bash
ls -l
```

**Description:**
Displays files and directories in long listing format with permissions, owner, size, and date.

---

## Option: -la

```bash
ls -la
```

**Description:**
Displays all files including hidden files in long listing format.

---

## Option: -R

```bash
ls -R
```

**Description:**
Displays files and directories recursively including subdirectories.

## Example

```bash
ls
```

## Sample Output

```text
Documents  Downloads  Pictures  file1.txt  file2.txt
```

# 9. Write a UNIX command to create a file, copy one file to another file and move one file to another.

## Create a File

### Command

```bash
touch file1.txt
```

### Description

The `touch` command is used to create an empty file.

---

## Copy One File to Another File

### Command

```bash
cp file1.txt file2.txt
```

### Description

The `cp` command copies the contents of one file to another file.

---

## Move One File to Another File

### Command

```bash
mv file1.txt file2.txt
```

### Description

The `mv` command moves or renames a file from one location to another.

---

## Option: cp -i

```bash
cp -i file1.txt file2.txt
```

**Description:**
Prompts before overwriting an existing file.

---

## Option: cp -r

```bash
cp -r dir1 dir2
```

**Description:**
Copies directories recursively.

---

## Option: mv -i

```bash
mv -i file1.txt file2.txt
```

**Description:**
Prompts before overwriting an existing file.

## Example

```bash
touch file1.txt
cp file1.txt file2.txt
mv file2.txt newfile.txt
```

# 10. Write a UNIX command to compare the contents of two files and delete a file.

## Compare Two Files

### Command

```bash
cmp file1.txt file2.txt
```

### Description

The `cmp` command compares the contents of two files byte by byte and reports the first difference found.

---

## Option: -l

```bash
cmp -l file1.txt file2.txt
```

**Description:**
Displays all differing bytes between the two files.

---

## Option: -s

```bash
cmp -s file1.txt file2.txt
```

**Description:**
Performs a silent comparison and displays no output if files are identical.

---

## Delete a File

### Command

```bash
rm file1.txt
```

### Description

The `rm` command removes or deletes a file from the system.

---

## Option: -i

```bash
rm -i file1.txt
```

**Description:**
Prompts for confirmation before deleting the file.

---

## Option: -f

```bash
rm -f file1.txt
```

**Description:**
Forces file deletion without confirmation.

## Example

```bash
cmp file1.txt file2.txt
rm file1.txt
```
# **PART - B**

# 11. Write the Scroll Key Commands in VI Editor.

## Description

Scroll commands in the VI editor are used to move the screen up and down without changing the cursor position significantly.

---

| Command | Description |
|----------|-------------|
| Ctrl + f | Scroll forward one full screen |
| Ctrl + b | Scroll backward one full screen |
| Ctrl + d | Scroll down half screen |
| Ctrl + u | Scroll up half screen |
| Ctrl + e | Scroll screen up by one line |
| Ctrl + y | Scroll screen down by one line |
| z + Enter | Move current line to top of screen |
| z . | Move current line to center of screen |
| z - | Move current line to bottom of screen |

---

## Example

```bash
Ctrl + f
```

Scrolls forward by one full screen.

```bash
Ctrl + b
```

Scrolls backward by one full screen.

# 12. Write a common symbolic chmod commands.

## Command

```bash
chmod
```

## Description

The `chmod` (Change Mode) command is used to change file and directory permissions in UNIX/Linux systems.

---

## Symbols Used in chmod

| Symbol | Meaning |
|----------|---------|
| u | User (Owner) |
| g | Group |
| o | Others |
| a | All Users |
| + | Add Permission |
| - | Remove Permission |
| = | Assign Permission |
| r | Read Permission |
| w | Write Permission |
| x | Execute Permission |

---

## Common Symbolic chmod Commands

### Add Read Permission to User

```bash
chmod u+r file.txt
```

**Description:** Adds read permission for the file owner.

---

### Add Write Permission to User

```bash
chmod u+w file.txt
```

**Description:** Adds write permission for the file owner.

---

### Add Execute Permission to User

```bash
chmod u+x file.txt
```

**Description:** Adds execute permission for the file owner.

---

### Remove Read Permission from User

```bash
chmod u-r file.txt
```

**Description:** Removes read permission from the owner.

---

### Remove Write Permission from Group

```bash
chmod g-w file.txt
```

**Description:** Removes write permission from the group.

---

### Add Read Permission to Others

```bash
chmod o+r file.txt
```

**Description:** Adds read permission for others.

---

### Add Read and Write Permission to Group

```bash
chmod g+rw file.txt
```

**Description:** Adds read and write permissions to the group.

---

### Give Read Permission to All Users

```bash
chmod a+r file.txt
```

**Description:** Adds read permission to all users.

---

### Give Execute Permission to All Users

```bash
chmod a+x file.txt
```

**Description:** Adds execute permission to all users.

---

### Assign Read, Write and Execute Permission to User

```bash
chmod u=rwx file.txt
```

**Description:** Assigns read, write and execute permissions to the owner.


# 13. Write undo commands and which command is used to delete 5 lines.

## Undo Command

### Command

```bash
u
```

### Description

The `u` command is used to undo the last change made in the VI editor.

---

## Redo Command

### Command

```bash
Ctrl + r
```

### Description

The `Ctrl + r` command is used to redo the last undone change.

---

## Delete 5 Lines

### Command

```bash
5dd
```

### Description

The `5dd` command deletes five consecutive lines starting from the current cursor position.

---

## Other Common Delete Commands

### Delete Current Line

```bash
dd
```

**Description:**
Deletes the current line.

---

### Delete 3 Lines

```bash
3dd
```

**Description:**
Deletes three lines from the current cursor position.

---

### Delete Word

```bash
dw
```

**Description:**
Deletes a word from the cursor position.

# 14. What are the commands to move cursor left, down, up and right.

## Description

In the VI editor, cursor movement commands are used to navigate through the text without entering insert mode.

---

## Cursor Movement Commands

| Command | Description |
|----------|-------------|
| h | Move cursor left |
| j | Move cursor down |
| k | Move cursor up |
| l | Move cursor right |

---

## Examples

### Move Cursor Left

```bash
h
```

**Description:**
Moves the cursor one character to the left.

---

### Move Cursor Down

```bash
j
```

**Description:**
Moves the cursor one line downward.

---

### Move Cursor Up

```bash
k
```

**Description:**
Moves the cursor one line upward.

---

### Move Cursor Right

```bash
l
```

**Description:**
Moves the cursor one character to the right.

---

## Additional Movement Commands

```bash
0
```

Moves the cursor to the beginning of the line.

```bash
$
```

Moves the cursor to the end of the line.

```bash
w
```

Moves the cursor to the beginning of the next word.

```bash
b
```

Moves the cursor to the beginning of the previous word.

# 15. Which command is used to insert a new line which appears after cursor & which command is used to delete at begin after cursor.

## Insert a New Line After the Current Cursor Line

### Command

```bash
o
```

### Description

The `o` command opens a new line below the current line and places the editor in insert mode.

---

## Delete Character After Cursor

### Command

```bash
x
```

### Description

The `x` command deletes the character at the cursor position.

---

## Delete Character Before Cursor

### Command

```bash
X
```

### Description

The `X` command deletes the character before the cursor position.

## Example

```bash
o
```

Opens a new line below the current line.

```bash
x
```

Deletes the character at the cursor position.


# 16. Which command is used to delete the text object, replace a text object with new text & which command is used to repeat the previous command.

## Delete a Text Object

### Command

```bash
d
```

### Description

The `d` command is used to delete a text object. It is usually combined with movement commands such as `dw`, `dd`, and `d$`.

---

## Replace a Text Object with New Text

### Command

```bash
c
```

### Description

The `c` (change) command deletes the specified text object and enters insert mode to replace it with new text.

### Example

```bash
cw
```

Changes the current word.

---

## Repeat the Previous Command

### Command

```bash
.
```

### Description

The `.` (dot) command repeats the last editing command executed in the VI editor.

## Examples

```bash
dd
```

Deletes the current line.

```bash
cw
```

Changes the current word.

```bash
.
```

Repeats the previous command.