defmodule DnaSequenceTest do
  use ExUnit.Case, async: true

  test "it should return a valid result for #{"ACTG"}" do
    assert DnaSequence.dnaSequence("ACTG") == 1
  end

  test "it should return a valid result for #{"ACTGA"}" do
    assert DnaSequence.dnaSequence("ACTGA") == 2
  end

  test "it should return a valid result for #{"ACTGACTG"}" do
    assert DnaSequence.dnaSequence("ACTGACTG") == 6
  end

  test "it should return a valid result for #{"A"}" do
    assert DnaSequence.dnaSequence("A") == 0
  end

  test "it should return a valid result for #{"AAA"}" do
    assert DnaSequence.dnaSequence("AAA") == 0
  end

  assert "it should return a valid result for #{"ACTGACTGACTG"}" do
    assert DnaSequence.dnaSequence("ACTGACTGACTG") == 15
  end
end
