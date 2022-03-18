# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

My program provides an efficient tool that sums multiple values. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video shows the program taking in multiple values then returning the sum of all of them. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program receives numerical values from the user, then returns the sum off all of them. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
values.Add(int.Parse(Console.ReadLine()));
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (int value in values)
    {
    result = result + value;
    }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable {values}.

### 3b iv.

Describes what the data contained in the list represents in your program

The list 'values' stores all of the user inputted numerical values that will be summed. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without a list, I would not have a consolidated way to store all of the user inputted numbers. I would need an unknown amount of variables, and constantly create new ones to store inputted values to sum. This would be cumbersome and impossible to keep track of. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static int SumAll(List<int> values)
        {
            if (values == null) // see if list is null or 0 then throw exception 
            {
                throw new ArgumentNullException("List of sums may not be null");
            }
            if (values.Count == 0) // see if list is null or 0 then throw exception 
            {
                throw new ArgumentException("The list of values must contain at least 1 value");
            }
            int result;
            result = 0;
            foreach (int value in values)
            {
                result = result + value;
            }
            return result; 
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
sum = SumAll(values);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

All of the user inputted numbers that will be summed are stored in the list under variable name 'values'. The method takes in the list 'values' and sums all of the numerical values in it. Summing the values is the main functionality of my program. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Check to see if the list values is null
2. If it is, throw an exception stating that the list is null
3. Check to see if the list values is empty
4. If it is, throw an exception stating that the list is empty
5. Create a variable called 'result' and set it to 0
6. For each value in list values, add the 'result' to the value
7. Return 'result'

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

SumAll(null)

Second call:

//Assume values is a list that contains 3 values 
SumAll(values)

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Testing that the list 'values' is null or length is 0. This will execute the body of the first if statement. 

Condition(s) tested by the second call:

Testing that the list 'values' is null or length is 0. This will skip the body of both if statements. 

### 3d iii.

Result of the first call:

The result of calling a null list will result in an exception being thrown. 

Result of the second call:

The result of calling a list of 3 values will result in iteration that sums all 3 values. 