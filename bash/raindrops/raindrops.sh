#!/usr/bin/env bash

ARG=$1
export RES

makeSound() {
  if [[ $(($1 % 3)) -eq 0 ]]; then
    RES+="Pling"
  fi

  if [[ $(($1 % 5)) -eq 0 ]]; then
    RES+="Plang"
  fi

  if [[ $(($1 % 7)) -eq 0 ]]; then
    RES+="Plong"
  fi
}

makeSound $ARG
if [[ -z $RES ]]; then
  echo $ARG
else
  echo $RES
fi
