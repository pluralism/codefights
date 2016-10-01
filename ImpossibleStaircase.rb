def adjacentNodes(staircase, current_node, visited)
  nodes = []

  # Down
  if current_node[0] + 1 < staircase.length
    # Check if the node below is a "v"
    if staircase[current_node[0] + 1][current_node[1]] == "v"
      nodes << [current_node[0] + 2, current_node[1], -1]
    end

    # Check if the node below is a "^"
    if staircase[current_node[0] + 1][current_node[1]] == "^"
      nodes << [current_node[0] + 2, current_node[1], 1]
    end
  end

  # Up
  if current_node[0] - 1 > 0
    # Check if the node above is a "v"
    if staircase[current_node[0] - 1][current_node[1]] == "v"
      nodes << [current_node[0] - 2, current_node[1], 1]
    end

    # Check if the node above is a "^"
    if staircase[current_node[0] - 1][current_node[1]] == "^"
      nodes << [current_node[0] - 2, current_node[1], -1]
    end
  end

  # Left
  if current_node[1] - 1 > 0
    # Check if the node to the left is a "<"
    if staircase[current_node[0]][current_node[1] - 1] == "<"
      nodes << [current_node[0], current_node[1] - 2, -1]
    end

    # Check if the node to the left is a ">"
    if staircase[current_node[0]][current_node[1] - 1] == ">"
      nodes << [current_node[0], current_node[1] - 2, 1]
    end
  end

  # Right
  if current_node[1] + 1 < staircase[0].length
    # Check if the node to the right is a "<"
    if staircase[current_node[0]][current_node[1] + 1] == "<"
      nodes << [current_node[0], current_node[1] + 2, 1]
    end

    # Check if the node to the right is a ">"
    if staircase[current_node[0]][current_node[1] + 1] == ">"
      nodes << [current_node[0], current_node[1] + 2, -1]
    end
  end

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

  while !queue.empty?
    current_node = queue.shift
    adjs = adjacentNodes(staircase, current_node, visited)

    adjs.each do |node|
      if !visited[node[0]][node[1]]
        # Mark the node as visited
        visited[node[0]][node[1]] = true
        # Update the height of the node
        height[node[0]][node[1]] = height[current_node[0]][current_node[1]] + node[2]
        # Add the node to the queue (only the second and third final -> I and J coordinates)
        queue << [node[0], node[1]]
      else
        return true if height[current_node[0]][current_node[1]] + node[2] != height[node[0]][node[1]]
      end
    end
  end

  false
end
