def next_nodes(node, staircase)
  nodes = []
  # Below
  nodes << [node[0] + 1, node[1]] if node[0] + 1 < staircase.length
  # Up
  nodes << [node[0] - 1, node[1]] if node[0] - 1 >= 0
  # Left
  nodes << [node[0], node[1] - 1] if node[1] - 1 >= 0
  # Right
  nodes << [node[0], node[1] + 1] if node[1] + 1 < staircase[0].length
  nodes
end


def ImpossibleStaircase(staircase)
  visited = Array.new(staircase.length) { Array.new(staircase[0].length, false) }
  height = Array.new(staircase.length) { Array.new(staircase[0].length, 1000) }
  new_staircase = []
  staircase.each do |n| new_staircase << n.chars end
  start_node, queue = [], []

  new_staircase.each_index { |i| j = new_staircase[i].index '#'; start_node = [i, j]; break }
  visited[start_node[0]][start_node[1]] = true
  queue << start_node

  current_node = queue.pop
  nodes = next_nodes(current_node, staircase)
  nodes.each do |node|
    next if staircase[node[0]][node[1]] == ' '
    val = staircase[node[0]][node[1]]
    if val == 'v'
      height[node[0] + 1][node[1]] = height[node[0] - 1][node[1]] - 1
    elsif val == '<'
      height[node[0]][node[1] + 1] = height[node[0]][node[1] - 1] + 1
    elsif val == '>'
      height[node[0]][node[1] + 1] = height[node[0]][node[1] - 1] - 1
    end
    visited[node[0]][node[1]] = true
    queue << [node[0], node[1]]
    p queue
  end


  visited.each do |n|
    p n
    puts
  end
  #while !queue.empty?
  #end
end


staircase = ["#  ",
             "v  ",
             "#<#",
             "v v",
             "#>#"]

ImpossibleStaircase(staircase)
