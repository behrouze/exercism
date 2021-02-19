#!/usr/bin/env bash

export WHO
if [[ -z $* ]]; then
  WHO="you"
else
  WHO="$1"
fi

echo "One for $WHO, one for me."
