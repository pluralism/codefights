defmodule IsItPoem do
  @moduledoc false

  @spec isItPoem([Integer, ...], [String.t, ...]) :: boolean
  def isItPoem(rhyme, text) do
    Enum.map(Enum.chunk(text, length rhyme), fn chunk ->
      rhyme_zip = Enum.zip rhyme, chunk
      Enum.uniq(rhyme)
      |> Enum.map(fn num ->
        Enum.filter(rhyme_zip, fn {num2, _} -> num == num2 end)
        |> Enum.map(fn {_, text} -> String.slice(text, -3..-1) end)
        |> Enum.uniq
        |> length
      end)
    end)
    |> List.flatten
    |> Enum.all?(&(&1 == 1))
  end
end
