defmodule StairsGain do
  def stairsGain(s) do
    d = [0, (if s |> String.at(0) == "y", do: 1, else: -2)]
    Enum.reduce((2..(String.length(s))) |> Enum.to_list, d, fn(i, acc) ->
      t = if (s |> String.at(i - 2)) == "y", do: 2, else: -1
      acc ++ [(if (s |> String.at(i - 1)) == "y", do: Enum.max([Enum.at(acc, i - 1) + 1, Enum.at(acc, i - 2) + t + 1]), else: Enum.max([Enum.at(acc, i - 1) - 2, Enum.at(acc, i - 2) + t - 2]))]
    end) |> List.last
  end
end
