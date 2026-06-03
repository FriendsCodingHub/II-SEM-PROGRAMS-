#!/bin/bash

echo "Control Statements Demo"

for i in 1 2 3; do
    if [ $i -eq 2 ]; then
        continue
    fi
    echo "FOR Loop: $i"
done

n=1

while [ $n -le 2 ]; do
    echo "WHILE Loop: $n"
    n=$((n+1))
done

echo "1) Add  2) Subtract  3) Exit"
read ch

case $ch in
1) echo "Sum = $((5+2))" ;;
2) echo "Sub = $((5-2))" ;;
3) echo "Program Exited"; exit ;;
*) echo "Wrong Choice" ;;
esac