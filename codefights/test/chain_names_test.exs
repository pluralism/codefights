defmodule ChainNamesTest do
  use ExUnit.Case, async: true


  test "it should have the right value for #{["Raymond",  "Nora", "Daniel", "Louie", "Peter", "Esteban"]}" do
    assert ChainNames.chainNames(["Raymond",  "Nora", "Daniel", "Louie", "Peter", "Esteban"]) == ["Peter", "Raymond", "Daniel", "Louie", "Esteban", "Nora"]
  end

  test "it should have the right value for #{["Haydee", "Tai", "Elliott", "Inocencia", "Archie"]}" do
    assert ChainNames.chainNames(["Haydee", "Tai", "Elliott", "Inocencia", "Archie"]) == ["Haydee", "Elliott", "Tai", "Inocencia", "Archie"]
  end

  test "it should have the right value for #{["Yee", "Estelle", "Vickey"]}" do
    assert ChainNames.chainNames(["Yee", "Estelle", "Vickey"]) == ["Vickey", "Yee", "Estelle"]
  end

  test "it should have the right value for #{["Kristine", "Inocencia", "Ayako", "Olin", "Nguyet", "Esteban", "Tai"]}" do
    assert ChainNames.chainNames(["Kristine", "Inocencia", "Ayako", "Olin", "Nguyet", "Esteban", "Tai"]) == ["Kristine", "Esteban", "Nguyet", "Tai", "Inocencia", "Ayako", "Olin"]
  end

  test "it should have the right value for #{["Waylon", "Alvera", "Nora"]}" do
    assert ChainNames.chainNames(["Waylon", "Alvera", "Nora"]) == ["Waylon", "Nora", "Alvera"]
  end
end
