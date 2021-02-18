export const steps = (number, counter = 0) => {
  if (number < 1) throw new Error('Only positive numbers are allowed');

  while (number !== 1) {
    number = number % 2 === 0 ? number / 2 : 3 * number + 1;
    counter++;
  }

  return counter;
};

//// Exercism most stared solution:
//// https://exercism.io/tracks/javascript/exercises/collatz-conjecture/solutions/051b003453f84df680e816ebecbc1d8d
// export const steps = (n, count = 0) => {
//   if (n <= 0) throw "Only positive numbers are allowed";
//   if (n === 1) return count;
//   return steps(n % 2 === 0 ? n / 2 : n * 3 + 1, count + 1);
// };
